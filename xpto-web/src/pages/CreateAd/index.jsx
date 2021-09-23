import React, { useState } from 'react';
import './styles.css';
import { Header } from '../../components/Header';
import { Footer } from '../../components/Footer';
import { Button } from '../../components/Button';
import { useHistory } from 'react-router';

export function CreateAd() {
  const history = useHistory();
  const [title, setTitle] = useState('');
  const [price, setPrice] = useState('');
  const [imgLink, setImgLink] = useState('');
  const [description, setDescription] = useState('');

  const createAd = (e) => {
    e.preventDefault();
    console.log(title, price, imgLink, description);
    history.push('/products');
  };

  return (
    <div>
      <Header></Header>
      <div className="divCreateAd">
        <div className="contentArea">
          <h1 className="createNewAdTitle">Criar novo anúncio</h1>
          <div>
            <form onSubmit={(e) => createAd(e)}>
              <div className="rowEspecial">
                <div className="col-md-6">
                  <h2>Titulo do anuncio</h2>
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
      <Footer></Footer>
    </div>
  );
}
