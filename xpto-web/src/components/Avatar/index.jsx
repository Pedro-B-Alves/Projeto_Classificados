import React from 'react';
import { AvatarWrapper } from './styles/AvatarWrapper';

export function Avatar({ photo }) {
  return (
    <AvatarWrapper>
      <img src={photo} alt="Foto da pessoa" />
    </AvatarWrapper>
  );
}
