import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import { AdCard } from '../../components/AdCard';
import { Button } from '../../components/Button';
import { Footer } from '../../components/Footer';
import { Header } from '../../components/Header';
import { ads } from '../../mock/ads';
import { api } from '../../services/api';
import { parseJwt } from '../../services/auth';
import { ProfileWrapper } from './styles/ProfileWrapper';

export function Profile() {
  const [isMyAds, setIsMyAds] = useState(true);
  const [isMyInterests, setIsMyInterests] = useState(false);
  const [interestsList, setInterestsList] = useState([]);
  const [adsList, setAdsList] = useState([]);
  const userInfo = localStorage.getItem('userToken') !== null && parseJwt();

  function handleShowMyAds() {
    setIsMyAds(true);
    setIsMyInterests(false);
  }

  function handleShowMyInterests() {
    setIsMyAds(false);
    setIsMyInterests(true);
  }

  async function getMyInterests(id) {
    const token = localStorage.getItem('userToken');

    const { data, status } = await api.get(`/interesse/user/${id}`, {
      headers: {
        Authorization: 'Bearer ' + token,
      },
    });

    if (status === 200) {
      setInterestsList(data);
      // const isInterested = data.find(
      //   (x) => x.idUsuarioNavigation.idUsuario == tokenDecoded.jti
      // );
      console.log(data);
    }
  }

  async function getMyAds(id) {
    const token = localStorage.getItem('userToken');

    const { data, status } = await api.get(`/anuncio/user/${id}`, {
      headers: {
        Authorization: 'Bearer ' + token,
      },
    });

    if (status === 200) {
      setAdsList(data);
      // const isInterested = data.find(
      //   (x) => x.idUsuarioNavigation.idUsuario == tokenDecoded.jti
      // );
      console.log(data);
    }
  }

  useEffect(() => {
    getMyInterests(userInfo.jti);
    getMyAds(userInfo.jti);
  }, [userInfo.jti]);

  // async function getMyInterests() {
  //   const token = localStorage.getItem('userToken');

  //   const { data, status } = await api.get(`/interesse/${id}`, {
  //     headers: {
  //       Authorization: 'Bearer ' + token,
  //     },
  //   });

  //   if (status === 200) {
  //     setInterestsList(data);
  //     // const isInterested = data.find(
  //     //   (x) => x.idUsuarioNavigation.idUsuario == tokenDecoded.jti
  //     // );
  //     console.log(data);
  //   }
  // }

  return (
    <ProfileWrapper>
      <Header />
      <div style={{ flex: '1' }}>
        <div className="profile-container">
          <h1>Minha conta</h1>
          <div style={{ display: 'flex', gap: '24px', marginTop: '24px' }}>
            <Button border={!isMyAds} onClick={handleShowMyAds}>
              Meus anúncios
            </Button>
            <Button border={!isMyInterests} onClick={handleShowMyInterests}>
              Meus interesses
            </Button>
          </div>

          <div className="profile-cards-container">
            {ads.length > 0 && isMyInterests
              ? interestsList.map((ad) => (
                  <Link to={`/ad/${ad.idAnuncio}`}>
                    <AdCard
                      key={ad.idAnuncio}
                      urlImage={ad.idAnuncioNavigation.imagem}
                      title={ad.idAnuncioNavigation.nome}
                      location="São Paulo"
                      interestsNumber="10"
                      price={ad.idAnuncioNavigation.preco}
                    />
                  </Link>
                ))
              : adsList.map((ad) => (
                  <Link to={`/ad/${ad.idAnuncio}`}>
                    <AdCard
                      key={ad.idAnuncio}
                      urlImage={ad.imagem}
                      title={ad.nome}
                      location="São Paulo"
                      interestsNumber="10"
                      price={ad.preco}
                    />
                  </Link>
                ))}
          </div>
        </div>
      </div>
      <Footer />
    </ProfileWrapper>
  );
}
