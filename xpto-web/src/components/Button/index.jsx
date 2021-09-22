import React from 'react';
import { ButtonWrapper } from './styles/ButtonWrapper';

export function Button({ children, ghost, border, banner, tag, ...props }) {
  return (
    <ButtonWrapper
      ghost={ghost}
      border={border}
      banner={banner}
      as={tag}
      {...props}
    >
      {children}
    </ButtonWrapper>
  );
}
