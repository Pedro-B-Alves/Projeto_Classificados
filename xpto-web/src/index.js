import React from 'react';
import ReactDOM from 'react-dom';
import { Home } from './pages/Home';
import { Login } from './pages/Login';
import { Products } from './pages/Products';
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
      <Route exact path="*" component={Home} />
    </Switch>
  </Router>
);

ReactDOM.render(routing, document.getElementById('root'));
