import React from 'react';
import { Button } from '../Button';
import { HeaderWrapper } from './styles/HeaderWrapper';
import { useHistory, Link } from 'react-router-dom';
import { Avatar } from '../Avatar';

export function Header() {
  const history = useHistory();
  const userLoggedIn = true;

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
          <div style={{ display: 'flex', alignItems: 'center', gap: '24px' }}>
            {userLoggedIn ? (
              <>
                {/* <Link to="/">Inicio</Link> */}
                <Link to="/products">Produtos</Link>
                <Link to="/">Anunciar</Link>
                <div
                  className="header-avatar"
                  style={{
                    display: 'flex',
                    alignItems: 'center',
                    gap: '24px',
                  }}
                >
                  <span>Bem-vindo, Fulano!</span>
                  <Link to="/profile">
                    <Avatar />
                  </Link>
                </div>
              </>
            ) : (
              <>
                <Button onClick={redirect} ghost>
                  Entrar
                </Button>
                <Button>Quero anunciar</Button>
              </>
            )}
          </div>
        </div>
      </div>
    </HeaderWrapper>
  );
}
