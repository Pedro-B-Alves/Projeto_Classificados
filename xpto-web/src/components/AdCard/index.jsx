import React from 'react';
import { AdCardWrapper } from './styles/AdCardWrapper';
import HearthIcon from '../../img/HearthIcon.svg';

export function AdCard({ urlImage, title, location, interestsNumber, price }) {
  function adCardClick() {
    console.log('teste');
  }

  return (
    <AdCardWrapper onClick={adCardClick}>
      <div className="contentTextInfo">
        <div style={{ width: '360px', height: '360px' }}>
          <img src={urlImage} className="image" alt="Imagem do produto" />
        </div>
        <h2>{title}</h2>
        <p>{location}</p>
      </div>
      <div className="footerCard">
        <div className="interests">
          <span>{interestsNumber}</span>
          <img src={HearthIcon} />
        </div>
        <span>{price}</span>
      </div>
    </AdCardWrapper>
  );
}
