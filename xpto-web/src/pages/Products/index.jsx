import React from 'react';
import './styles.css';
import { Header } from '../../components/Header';
import { Footer } from '../../components/Footer';
import { Button } from '../../components/Button';
import { AdCard } from '../../components/AdCard';
import searchImg from '../../img/SearchImg.svg';
import Ps4Img from '../../img/PlaystationImg.png';
export function Products() {
  return (
    <div>
      <Header></Header>
      <section className="section">
        <div className="contentArea">
          <div className="navigationArea">
            <h1>Todos os produtos</h1>
            <div className="searchBar">
              <img src={searchImg} className="searchImgsvg" />
              <input type="text" placeholder="buscar" />
            </div>
          </div>
          <div className="contentCardsArea">
            <AdCard
              urlImage={Ps4Img}
              title="PS4 Slim - 1tb"
              location="Sao paulo - SP"
              interestsNumber="10"
              price="R$2.000,00"
            ></AdCard>
            <AdCard
              urlImage={Ps4Img}
              title="PS4 Slim - 1tb"
              location="Sao paulo - SP"
              interestsNumber="10"
              price="R$2.000,00"
            ></AdCard>
            <AdCard
              urlImage={Ps4Img}
              title="PS4 Slim - 1tb"
              location="Sao paulo - SP"
              interestsNumber="10"
              price="R$2.000,00"
            ></AdCard>
            <AdCard
              urlImage={Ps4Img}
              title="PS4 Slim - 1tb"
              location="Sao paulo - SP"
              interestsNumber="10"
              price="R$2.000,00"
            ></AdCard>
            <AdCard
              urlImage={Ps4Img}
              title="PS4 Slim - 1tb"
              location="Sao paulo - SP"
              interestsNumber="10"
              price="R$2.000,00"
            ></AdCard>
            <AdCard
              urlImage={Ps4Img}
              title="PS4 Slim - 1tb"
              location="Sao paulo - SP"
              interestsNumber="10"
              price="R$2.000,00"
            ></AdCard>
          </div>
          <div className="buttonSeeMore">
            <Button border>Ver mais...</Button>
          </div>
        </div>
      </section>
      <Footer></Footer>
    </div>
  );
}
