import React, { useState } from 'react';
import './styles.css';
import { Header } from '../../components/Header';
import { Footer } from '../../components/Footer';
import { Button } from '../../components/Button';
import { useHistory } from 'react-router';
import { api } from '../../services/api';
import { parseJwt } from '../../services/auth';

export function CreateAd() {
  const history = useHistory();
  const [title, setTitle] = useState('');
  const [price, setPrice] = useState('');
  const [imgLink, setImgLink] = useState('');
  const [description, setDescription] = useState('');
  const userInfo = localStorage.getItem('userToken') !== null && parseJwt();

  const createAd = async (e) => {
    e.preventDefault();
    const token = localStorage.getItem('userToken');

    console.log(title, price, imgLink, description);

    const { data, status } = await api.post(
      'Anuncio',
      {
        idUsuario: userInfo.jti,
        nome: title,
        preco: price,
        imagem: imgLink,
        descricao: description,
      },
      {
        headers: {
          Authorization: 'Bearer ' + token,
        },
      }
    );

    history.push('/products');
  };

  return (
    <div style={{ display: 'flex', flex: '1', flexDirection: 'column' }}>
      <Header />
      <div style={{ flex: '1' }}>
        <div className="divCreateAd">
          <div className="createAd-contentArea">
            <h1 className="createNewAdTitle">Criar novo anúncio</h1>
            <div>
              <form onSubmit={(e) => createAd(e)}>
                <div className="rowEspecial">
                  <div className="col-md-6">
                    <h2>Título do anuncio</h2>
                    <input
                      type="text"
                      value={title}
                      onChange={(e) => setTitle(e.target.value)}
                    />
                  </div>
                  <div className="col-md-6">
                    <h2>Preço</h2>
                    <input
                      type="text"
                      value={price}
                      onChange={(e) => setPrice(e.target.value)}
                    />
                  </div>
                </div>
                <div className="row">
                  <div className="col-md-12">
                    <h2>Link da imagem</h2>
                    <input
                      type="text"
                      value={imgLink}
                      onChange={(e) => setImgLink(e.target.value)}
                    />
                  </div>
                </div>
                <div className="row">
                  <div className="col-md-12">
                    <h2>Descrição</h2>
                    <input
                      type="text"
                      value={description}
                      onChange={(e) => setDescription(e.target.value)}
                    />
                  </div>
                </div>
                <div className="divButton">
                  <Button type="submit">Enviar</Button>
                </div>
              </form>
            </div>
          </div>
        </div>
      </div>
      <Footer />
    </div>
  );
}
