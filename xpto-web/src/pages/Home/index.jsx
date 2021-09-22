import React from 'react';
import './styles.css';
import { Header } from '../../components/Header';
import { Footer } from '../../components/Footer';
import { AdCard } from '../../components/AdCard';
import WomanImg from '../../img/WomanImg.png';
import BackImg from '../../img/BackImg.png';
import ManImg from '../../img/ManImg.png';
import Ps4Img from '../../img/PlaystationImg.png';
import WomanBuy from '../../img/BannerImg.svg';
import { Button } from '../../components/Button';

export function Home() {
  return (
    <div>
      <Header />
      <body>
        <main>
          <section>
            <div className="banner">
              <div className="bannerContent">
                <h1>
                  O melhor site &amp; app {'\n'}
                  para anunciar na internet!{' '}
                </h1>
                <hr />
                <Button banner>Quero Anunciar!</Button>
              </div>
              <img src={WomanBuy} />
            </div>
          </section>
          <section className="section">
            <div className="contentArea">
              <div className="contentBlock">
                <img src={WomanImg} />
                <div className="divText">
                  <h2>Anuncie seus produtos</h2>
                  <p>
                    Crie um anúncio daquele produto que não deseja mais.
                    Rapidamente ele estará disponível em nossa plataforma para
                    que outras pessoas possam ver e demonstrar interesse!
                  </p>
                </div>
              </div>
              <div className="contentBlock">
                <div className="divText">
                  <h2>Compre os produtos que deseja</h2>
                  <p>
                    Para comprar um produto também é muito simples, basta clicar
                    no botão ‘Demonstrar Interesse’ que o vendedor poderá
                    visualizar seu desejo
                  </p>
                </div>
                <img src={BackImg} />
              </div>
              <div className="contentBlock">
                <img src={ManImg} />
                <div className="divText">
                  <h2>Combine um local para efetuar a compra/venda</h2>
                  <p>
                    Assim que um produto tiver uma pessoa interessada, basta
                    combinar um local para fazer a compra/venda desse produto
                  </p>
                </div>
              </div>

              <div className="contentBlockRow">
                <h2>Anúncios recentes</h2>
                <div className="cardsArea">
                  <AdCard
                    urlImage={Ps4Img}
                    title="PS4 slim - 1tb"
                    location="Sao paulo - SP"
                    interestsNumber="10"
                    price="R$2.000,00"
                  ></AdCard>
                  <AdCard
                    urlImage={Ps4Img}
                    title="PS4 slim - 1tb"
                    location="Sao paulo - SP"
                    interestsNumber="10"
                    price="R$2.000,00"
                  ></AdCard>
                  <AdCard
                    urlImage={Ps4Img}
                    title="PS4 slim - 1tb"
                    location="Sao paulo - SP"
                    interestsNumber="10"
                    price="R$2.000,00"
                  ></AdCard>
                </div>
                <div className="bottomAdCards">
                  <a>Ver mais...</a>
                </div>
              </div>
            </div>
          </section>
        </main>
      </body>
      <Footer />
    </div>
  );
}
