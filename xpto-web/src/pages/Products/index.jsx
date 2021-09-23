import React from 'react';
import { Link } from 'react-router-dom';
import { Header } from '../../components/Header';
import { Footer } from '../../components/Footer';
import { AdCard } from '../../components/AdCard';
import { ads } from '../../mock/ads';

import searchImg from '../../img/SearchImg.svg';

import './styles.css';

export function Products() {
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
            {ads.length > 0 &&
              ads.map((ad) => (
                <Link to={`/ad/${ad.id}`}>
                  <AdCard
                    key={ad.id}
                    urlImage={ad.urlImage}
                    title={ad.title}
                    location={ad.location}
                    interestsNumber="10"
                    price={ad.price}
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
