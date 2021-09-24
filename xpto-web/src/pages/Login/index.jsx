import React, { useState } from 'react';
import './styles.css';
import { Link, useHistory } from 'react-router-dom';
import LoginImg from '../../img/LoginImg.png';
import { Button } from '../../components/Button';
import { api } from '../../services/api';
import axios from 'axios';

export function Login() {
  const history = useHistory();
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');

  const handleSignIn = async (e) => {
    e.preventDefault();

    const { data, status } = await api.post('/login', {
      email: email,
      senha: password,
    });

    if (status === 200) {
      localStorage.setItem('userToken', data.token);
      history.push('/products');
    }
  };

  return (
    <div className="mainArea">
      <div className="leftContentArea">
        <div className="limitLeftArea">
          <h1 style={{ alignSelf: 'flex-start', marginBottom: '48px' }}>
            XTPO
          </h1>
          <h2 style={{ marginBottom: '192px' }}>
            Bem-vindo ao melhor site &amp; app de anúncios do Brasil!
          </h2>
          <img src={LoginImg} alt="imagem de login" />
        </div>
      </div>
      <div className="rightContentArea">
        <div className="areaText">
          <h2>Faça seu login!</h2>
        </div>
        <form onSubmit={(e) => handleSignIn(e)}>
          <div className="inputArea">
            <h4>E-mail</h4>
            <input
              type="email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
            ></input>
          </div>
          <div className="inputArea">
            <h4>Senha</h4>
            <input
              type="password"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
            ></input>
          </div>

          <div className="bottomInputLogin">
            <div className="informations">
              <p>Ainda nao possui uma conta?</p>
              <Link to="/">Cadastre-se ja!</Link>
            </div>
            <Button type="submit">Enviar</Button>
          </div>
        </form>
      </div>
    </div>
  );
}
