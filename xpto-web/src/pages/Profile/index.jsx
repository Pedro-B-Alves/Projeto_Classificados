import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import { AdCard } from '../../components/AdCard';
import { Button } from '../../components/Button';
import { Footer } from '../../components/Footer';
import { Header } from '../../components/Header';
import { ads } from '../../mock/ads';
import { ProfileWrapper } from './styles/ProfileWrapper';

export function Profile() {
  const [isMyAds, setIsMyAds] = useState(true);
  const [isMyInterests, setIsMyInterests] = useState(false);

  function handleShowMyAds() {
    setIsMyAds(true);
    setIsMyInterests(false);
  }

  function handleShowMyInterests() {
    setIsMyAds(false);
    setIsMyInterests(true);
  }

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
            {ads.length > 0 && isMyAds
              ? ads.map((ad) => (
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
                ))
              : ads.slice(0, 3).map((ad) => (
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
      </div>
      <Footer />
    </ProfileWrapper>
  );
}
