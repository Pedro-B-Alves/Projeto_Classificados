import React from 'react';
import ReactDOM from 'react-dom';
import {Home} from './pages/Home';
import './index.css';
import { BrowserRouter as Router, Switch, Route, Redirect } from "react-router-dom";

export const routing = (
  <Router>
    <Switch>
      <Route exact path="*" component={Home} />
      <Route exact path="/" component={Home} />
    </Switch>
  </Router>
)

ReactDOM.render(
  routing,
  document.getElementById('root')
);
