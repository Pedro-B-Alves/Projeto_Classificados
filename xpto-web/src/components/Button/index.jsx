import React from 'react';
import { ButtonWrapper } from './styles/ButtonWrapper';

export function Button({ children, ghost, border, banner }) {
  return (
    <ButtonWrapper ghost={ghost} border={border} banner={banner}>
      {children}
    </ButtonWrapper>
  );
}
