import React from 'react';
import { Button } from '../Button';
import { HeaderWrapper } from './styles/HeaderWrapper';
import { useHistory, Link } from 'react-router-dom';
import { Avatar } from '../Avatar';
import { parseJwt, usuarioAutenticado } from '../../services/auth';

export function Header() {
  const history = useHistory();
  const userLoggedIn = usuarioAutenticado();
  const userInfo = localStorage.getItem('userToken') !== null && parseJwt();

  function handleSignout() {
    localStorage.removeItem('userToken');
    history.push('/');
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
                <Link to="/createad">Anunciar</Link>
                <Button ghost onClick={handleSignout}>
                  Sair
                </Button>
                <div
                  className="header-avatar"
                  style={{
                    display: 'flex',
                    alignItems: 'center',
                    gap: '24px',
                  }}
                >
                  <span>Bem-vindo, {userInfo.family_name}!</span>
                  <Link to="/profile">
                    <Avatar photo={userInfo.imagem} />
                  </Link>
                </div>
              </>
            ) : (
              <>
                <Button onClick={() => history.push('/login')} ghost>
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
