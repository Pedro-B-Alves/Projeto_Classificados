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
import { Link } from 'react-router-dom';
import { ads } from '../../mock/ads';

export function Home() {
  // const slicedArray = array.slice(0, n);
  return (
    <div>
      <Header />

      <main>
        <section className="bannerContainer">
          <div className="banner">
            <div className="bannerContent">
              <h1>
                O melhor site &amp; app {'\n'}
                para anunciar na internet!{' '}
              </h1>
              <hr />
              <Button banner>Quero Anunciar!</Button>
            </div>
            <img src={WomanBuy} alt="ilustração" />
          </div>
        </section>
        <section className="section">
          <div className="contentArea">
            <div className="contentBlock">
              <img src={WomanImg} alt="ilustração" />
              <div className="divText">
                <h2>Anuncie seus produtos</h2>
                <p>
                  Crie um anúncio daquele produto que não deseja mais.
                  Rapidamente ele estará disponível em nossa plataforma para que
                  outras pessoas possam ver e demonstrar interesse!
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
              <img src={BackImg} alt="ilustração" />
            </div>
            <div className="contentBlock">
              <img src={ManImg} alt="ilustração" />
              <div className="divText">
                <h2>Combine um local para efetuar a compra/venda</h2>
                <p>
                  Assim que um produto tiver uma pessoa interessada, basta
                  combinar um local para fazer a compra/venda desse produto
                </p>
              </div>
            </div>

            <div className="homeContentBlockRow">
              <h2 style={{ marginBottom: '48px' }}>Anúncios recentes</h2>
              <div className="cardsArea">
                {ads.length > 0 &&
                  ads.slice(0, 3).map((ad) => (
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
              <div className="bottomAdCards">
                <Link to="/login">Ver mais...</Link>
              </div>
            </div>
          </div>
        </section>
      </main>
      <Footer />
    </div>
  );
}
