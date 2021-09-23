import React from 'react';
import ReactDOM from 'react-dom';
import { Home } from './pages/Home';
import { Login } from './pages/Login';
import { Products } from './pages/Products';
import { AdPage } from './pages/AdPage';
import './index.css';
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';
import { Profile } from './pages/Profile';

export const routing = (
  <Router>
    <Switch>
      <Route exact path="/" component={Home} />
      <Route exact path="/login" component={Login} />
      <Route exact path="/products" component={Products} />
      <Route exact path="/ad/:id" component={AdPage} />
      <Route exact path="/profile" component={Profile} />
    </Switch>
  </Router>
);

ReactDOM.render(routing, document.getElementById('root'));
