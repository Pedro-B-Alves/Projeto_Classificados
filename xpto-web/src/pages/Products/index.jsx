import React from 'react';
import { Link } from 'react-router-dom';
import { Header } from '../../components/Header';
import { Footer } from '../../components/Footer';
import { AdCard } from '../../components/AdCard';
import searchImg from '../../img/SearchImg.svg';
import Ps4Img from '../../img/PlaystationImg.png';

import './styles.css';

export function Products() {
  return (
    <div>
      <Header></Header>
      <section className="section">
        <div className="contentArea">
          <div className="navigationArea">
            <h1>Todos os produtos</h1>
            <div className="searchBar">
              <img src={searchImg} className="searchImgsvg" alt="imagem" />
              <input type="text" placeholder="Buscar" />
            </div>
          </div>
          <div className="contentCardsArea">
            <Link to="/ad">
              <AdCard
                urlImage={Ps4Img}
                title="PS4 Slim - 1tb"
                location="Sao paulo - SP"
                interestsNumber="10"
                price="R$2.000,00"
              />
            </Link>
            <AdCard
              urlImage={Ps4Img}
              title="PS4 Slim - 1tb"
              location="Sao paulo - SP"
              interestsNumber="10"
              price="R$2.000,00"
            />
            <AdCard
              urlImage={Ps4Img}
              title="PS4 Slim - 1tb"
              location="Sao paulo - SP"
              interestsNumber="10"
              price="R$2.000,00"
            />
            <AdCard
              urlImage={Ps4Img}
              title="PS4 Slim - 1tb"
              location="Sao paulo - SP"
              interestsNumber="10"
              price="R$2.000,00"
            />
            <AdCard
              urlImage={Ps4Img}
              title="PS4 Slim - 1tb"
              location="Sao paulo - SP"
              interestsNumber="10"
              price="R$2.000,00"
            />
            <AdCard
              urlImage={Ps4Img}
              title="PS4 Slim - 1tb"
              location="Sao paulo - SP"
              interestsNumber="10"
              price="R$2.000,00"
            />
          </div>
          {/* <div className="buttonSeeMore">
            <Button border>Ver mais...</Button>
          </div> */}
        </div>
      </section>
      <Footer />
    </div>
  );
}
