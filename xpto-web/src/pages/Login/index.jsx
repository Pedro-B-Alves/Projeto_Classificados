import React from 'react';
import './styles.css';
import LoginImg from '../../img/LoginImg.png';
import { Button } from '../../components/Button';

export function Login() {
  return (
    <div className="mainArea">
      <div className="leftContentArea">
        <div className="limitLeftArea">
          <h1>XTPO</h1>
          <h2>Bem-Vindo ao melhor site e app de anuncios do Brasil!</h2>
          <img src={LoginImg} />
        </div>
      </div>
      <div className="rightContentArea">
        <h2>Faça seu login!</h2>
        <div class="inputArea">
          <h4>E-mail</h4>
          <input type="email"></input>
        </div>
        <div class="inputArea">
          <h4>Senha</h4>
          <input type="password"></input>
        </div>
        <div className="bottomInputLogin">
          <div className="informations">
            <p>Ainda nao possui uma conta?</p>
            <a href="#">Cadastre-se ja!</a>
          </div>
          <Button>Enviar</Button>
        </div>
      </div>
    </div>
  );
}
