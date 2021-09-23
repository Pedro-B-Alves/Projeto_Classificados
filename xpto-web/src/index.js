import React from 'react';
import ReactDOM from 'react-dom';
import { Home } from './pages/Home';
import { Login } from './pages/Login';
import { Products } from './pages/Products';
import { AdPage } from './pages/AdPage';
import { CreateAd } from './pages/CreateAd';
import './index.css';
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Redirect,
} from 'react-router-dom';

export const routing = (
  <Router>
    <Switch>
      <Route exact path="/login" component={Login} />
      <Route exact path="/products" component={Products} />
      <Route exact path="/" component={Home} />
      <Route exact path="/adpage" component={AdPage} />
      <Route exact path="/createad" component={CreateAd} />
    </Switch>
  </Router>
);

ReactDOM.render(routing, document.getElementById('root'));
