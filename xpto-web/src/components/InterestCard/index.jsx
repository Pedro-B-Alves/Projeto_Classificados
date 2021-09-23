import React from 'react';
import { Avatar } from '../Avatar';

import { InterestCardWrapper } from './styles/InterestCardWrapper';

export function InterestCard({ photo, name }) {
  return (
    <InterestCardWrapper>
      <div style={{ display: 'flex', alignItems: 'center', gap: '12px' }}>
        <Avatar photo={photo} />
        <div style={{ display: 'flex', flexDirection: 'column' }}>
          <span>{name}</span>
          <span>11 938401984</span>
        </div>
      </div>
    </InterestCardWrapper>
  );
}
