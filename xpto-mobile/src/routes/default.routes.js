import React from 'react';
import { createStackNavigator } from '@react-navigation/stack';

import { LoginScreen } from '../screens/LoginScreen';
import { AuthRoutes } from './auth.routes';

const { Navigator, Screen } = createStackNavigator();

export function DefaultRoutes() {
  return (
    //Define que haverá navegação
    <Navigator
      screenOptions={{
        headerShown: false,
        cardStyle: {
          backgroundColor: 'transparent',
          opacity: 1,
        },
      }}
    >
      <Screen name="LoginScreen" component={LoginScreen}></Screen>
      <Screen name="AuthRoutes" component={AuthRoutes}></Screen>
    </Navigator>
  );
}
