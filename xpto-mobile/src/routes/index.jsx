import React from 'react';
import { NavigationContainer } from '@react-navigation/native';

import { DefaultRoutes } from './default.routes';

export function Routes() {
  return (
    <NavigationContainer>
      <DefaultRoutes />
    </NavigationContainer>
  );
}
