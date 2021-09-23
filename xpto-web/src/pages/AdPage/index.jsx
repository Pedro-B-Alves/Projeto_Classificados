import React from 'react';
import { AdPageWrapper } from './styles/AdPageWrapper';
import { Header } from '../../components/Header';
import { Footer } from '../../components/Footer';
import { Avatar } from '../../components/Avatar';
import { Button } from '../../components/Button';

import HeartIcon from '../../img/HearthIcon.svg';
import { InterestCard } from '../../components/InterestCard';

export function AdPage() {
  return (
    <>
      <AdPageWrapper>
        <Header />
        <div style={{ flex: '1' }}>
          <div className="ad-page-container">
            <div className="ad-page-card">
              <div className="ad-page-left-content">
                <h1 className="ad-page-title">PS4 Slim - 1Tb</h1>
                <h2 className="ad-page-price">R$ 2000,00</h2>
                <div>
                  <span className="ad-page-info-subtitle">Anunciante</span>
                  <div className="ad-page-avatar">
                    <Avatar photo="https://github.com/vinixiii.png" />
                    <span className="ad-page-ad-owner">Vinícius Figueiroa</span>
                  </div>
                </div>
                <div className="ad-page-info-content">
                  <span className="ad-page-info-subtitle">Localização</span>
                  <span>São Paulo</span>
                </div>
                <div className="ad-page-info-content">
                  <span className="ad-page-info-subtitle">Descrição</span>
                  <span style={{ display: 'block' }}>
                    Lorem ipsum dolor sit amet consectetur adipisicing elit.
                    Amet omnis minima libero, odit quasi reiciendis inventore
                    accusamus ipsum tempore commodi ex autem ratione suscipit
                    doloremque odio necessitatibus, blanditiis recusandae a!
                  </span>
                </div>
              </div>

              <div className="ad-page-right-content">
                <img
                  className="ad-page-image"
                  src="https://github.com/vinixiii.png"
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

                <div
                  style={{
                    display: 'flex',
                    flexDirection: 'column',
                    gap: '12px',
                    marginTop: '48px',
                  }}
                >
                  <InterestCard
                    photo="https://github.com/vinixiii.png"
                    name="Vinícius Figueiroa"
                  />
                  <InterestCard
                    photo="https://github.com/vinixiii.png"
                    name="Vinícius Figueiroa"
                  />
                  <InterestCard
                    photo="https://github.com/vinixiii.png"
                    name="Vinícius Figueiroa"
                  />
                  <InterestCard
                    photo="https://github.com/vinixiii.png"
                    name="Vinícius Figueiroa"
                  />
                </div>
              </div>
            </div>
          </div>
        </div>
        <Footer />
      </AdPageWrapper>
    </>
  );
}
