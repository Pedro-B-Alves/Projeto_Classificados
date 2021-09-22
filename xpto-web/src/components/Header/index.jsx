import React from 'react';
import { Button } from '../Button';
import { HeaderWrapper } from './styles/HeaderWrapper';
import { useHistory } from 'react-router-dom';

export function Header() {
  const history = useHistory();

  function redirect(e) {
    e.preventDefault();
    history.push('/login');
  }

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
            <Button onClick={redirect} ghost>
              Entrar
            </Button>
            <Button>Quero anunciar</Button>
          </div>
        </div>
      </div>
    </HeaderWrapper>
  );
}
