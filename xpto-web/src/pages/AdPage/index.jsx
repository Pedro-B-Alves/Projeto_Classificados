import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router';
import { AdPageWrapper } from './styles/AdPageWrapper';
import { Header } from '../../components/Header';
import { Footer } from '../../components/Footer';
import { Avatar } from '../../components/Avatar';
import { Button } from '../../components/Button';

import HeartIcon from '../../img/HearthIcon.svg';
import { InterestCard } from '../../components/InterestCard';
import { api } from '../../services/api';
import { parseJwt } from '../../services/auth';

export function AdPage() {
  const { id } = useParams();
  const [adInfo, setAdInfo] = useState({});
  const [interestsList, setInterestsList] = useState([]);
  const userInfo = localStorage.getItem('userToken') !== null && parseJwt();

  async function getAdInfo(id) {
    const { data, status } = await api.get(`/anuncio/${id}`);

    if (status === 200) {
      setAdInfo(data);
      console.log(data);
    }
  }

  async function getInterests(id) {
    const token = localStorage.getItem('userToken');

    const { data, status } = await api.get(`/interesse/${id}`, {
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

  useEffect(() => {
    getAdInfo(id);
    getInterests(id);
  }, [id]);

  return (
    <>
      <AdPageWrapper>
        <Header />
        <div style={{ flex: '1' }}>
          <div className="ad-page-container">
            <div className="ad-page-card">
              <div className="ad-page-left-content">
                <h1 className="ad-page-title">{adInfo.nome}</h1>
                <h2 className="ad-page-price">R$ {adInfo.preco},00</h2>
                <div>
                  <span className="ad-page-info-subtitle">Anunciante</span>
                  <div className="ad-page-avatar">
                    <Avatar photo={adInfo.idUsuarioNavigation?.imagem} />
                    <span className="ad-page-ad-owner">
                      {adInfo.idUsuarioNavigation?.nome}
                    </span>
                  </div>
                </div>
                <div className="ad-page-info-content">
                  <span className="ad-page-info-subtitle">Localização</span>
                  <span>{adInfo.idUsuarioNavigation?.cidade}</span>
                </div>
                <div className="ad-page-info-content">
                  <span className="ad-page-info-subtitle">Descrição</span>
                  <span style={{ display: 'block' }}>{adInfo.descricao}</span>
                </div>
              </div>

              <div className="ad-page-right-content">
                <img
                  className="ad-page-image"
                  src={adInfo.imagem}
                  alt="Imagem do produto"
                />
              </div>
            </div>

            <div
              style={{
                display: 'flex',
                justifyContent: 'space-between',
                margin: '48px 0',
              }}
            >
              <div
                style={{
                  display: 'flex',
                  flexDirection: 'column',
                  width: '48%',
                  gap: '12px',
                }}
              >
                <h2 className="ad-page-subtitle">Ficou interessado?</h2>
                <span>
                  Basta clicar no botão abaixo e demonstrar interesse por esse
                  produto!
                </span>
                <div style={{ maxWidth: '256px', marginTop: '24px' }}>
                  <Button border>Estou interessado!</Button>
                </div>
              </div>

              <div
                style={{
                  display: 'flex',
                  flexDirection: 'column',
                  width: '48%',
                  marginBottom: '48px',
                }}
              >
                <div
                  style={{
                    display: 'flex',
                    alignItems: 'center',
                    justifyContent: 'space-between',
                  }}
                >
                  <h2 className="ad-page-subtitle">Pessoas interessadas</h2>
                  <div
                    style={{
                      display: 'flex',
                      alignItems: 'center',
                      gap: '12px',
                    }}
                  >
                    <span>2</span>
                    <img
                      src={HeartIcon}
                      alt="Ícone de coração"
                      style={{ width: '24px', height: '24px' }}
                    />
                  </div>
                </div>

                {userInfo.jti !== adInfo.idUsuario?.toString() ? (
                  <div
                    style={{
                      display: 'flex',
                      flexDirection: 'column',
                      gap: '12px',
                      marginTop: '48px',
                    }}
                  >
                    {interestsList.map((interest) => (
                      <InterestCard
                        photo={interest.idUsuarioNavigation?.imagem}
                        name={interest.idUsuarioNavigation?.nome}
                      />
                    ))}
                  </div>
                ) : (
                  <div
                    style={{
                      display: 'flex',
                      flexDirection: 'column',
                      gap: '12px',
                      marginTop: '48px',
                    }}
                  >
                    {interestsList.map((interest) => (
                      <InterestCard
                        photo={interest.idUsuarioNavigation?.imagem}
                        name={interest.idUsuarioNavigation?.nome}
                        phone={interest.idUsuarioNavigation?.telefone}
                      />
                    ))}
                  </div>
                )}
              </div>
            </div>
          </div>
        </div>
        <Footer />
      </AdPageWrapper>
    </>
  );
}
