import React from 'react';
import { AdCardWrapper } from './styles/AdCardWrapper';
import HearthIcon from '../../img/HearthIcon.svg';

export function AdCard({ urlImage, title, location, interestsNumber, price }) {
  return (
    <AdCardWrapper>
      <div className="contentTextInfo">
        <img src={urlImage} className="image" />
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
