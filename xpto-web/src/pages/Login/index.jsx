import React, { useState } from 'react';
import './styles.css';
import { useHistory } from 'react-router-dom';
import LoginImg from '../../img/LoginImg.png';
import { Button } from '../../components/Button';
import axios from 'axios';

export function Login() {
  const history = useHistory();
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');

  const handleSignIn = (e) => {
    

    axios
      .post('https://localhost:5001/v1/account/signin', {
        email: email,
        senha: password,
      })
      .then((res) => {
        if (res.data.mensagem === 'Logado com sucesso!') {
          localStorage.setItem('token', res.data.token);

          history.push('/products');
        }
      });
    console.log(email, password);
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
          <img src={LoginImg} />
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
              <a href="#">Cadastre-se ja!</a>
            </div>
            <Button type="submit">Enviar</Button>
          </div>
        </form>
      </div>
    </div>
  );
}
