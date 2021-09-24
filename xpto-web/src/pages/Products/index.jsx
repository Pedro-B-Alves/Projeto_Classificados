import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import { Header } from '../../components/Header';
import { Footer } from '../../components/Footer';
import { AdCard } from '../../components/AdCard';
import { api } from '../../services/api';
import { ads } from '../../mock/ads';

import searchImg from '../../img/SearchImg.svg';

import './styles.css';

export function Products() {
  const [adsList, setAdsList] = useState([]);

  async function getAdsList() {
    const { data, status } = await api.get('/anuncio');

    if (status === 200) {
      setAdsList(data);
      console.log(data);
    }
  }

  useEffect(() => {
    getAdsList();
  }, []);

  return (
    <div style={{ display: 'flex', flex: 1, flexDirection: 'column' }}>
      <Header />
      <section style={{ flex: 1, margin: '0 auto', marginTop: '64px' }}>
        <div className="contentArea">
          <div className="navigationArea">
            <h1>Todos os produtos</h1>
            <div className="searchBar">
              <img src={searchImg} className="searchImgsvg" alt="imagem" />
              <input type="text" placeholder="Buscar" />
            </div>
          </div>
          <div className="contentCardsArea">
            {adsList.length > 0 &&
              adsList.map((ad) => (
                <Link to={`/ad/${ad.idAnuncio}`}>
                  <AdCard
                    key={ad.idAnuncio}
                    urlImage={ad.imagem}
                    title={ad.nome}
                    location={ad.idUsuarioNavigation.cidade}
                    interestsNumber="10"
                    price={ad.preco}
                  />
                </Link>
              ))}
          </div>
        </div>
      </section>
      <Footer />
    </div>
  );
}
