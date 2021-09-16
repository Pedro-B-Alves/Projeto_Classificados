import React from 'react';
import { Button } from '../Button';
import { HeaderWrapper } from './styles/HeaderWrapper';

export function Header() {
  return (
    <HeaderWrapper>
      <div className="contentAreaHeader">
        <div className="firstBlock">
          <div className="divLogo">
            <h1>XTPO</h1>
          </div>
          <div>
            <a href="#">Inicio</a>
            <a href="#">Produtos</a>
            <a href="#">Anunciar</a>
            <Button ghost>Entrar</Button>
            <Button>Quero anunciar</Button>
          </div>
        </div>
      </div>
    </HeaderWrapper>
  );
}
