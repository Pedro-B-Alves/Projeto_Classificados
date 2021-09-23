import React from 'react';
import { createStackNavigator } from '@react-navigation/stack';
import { getStatusBarHeight } from 'react-native-iphone-x-helper';

import { theme } from '../global/styles/theme';
import { AdsScreen } from '../screens/AdsScreen';
import { AccountScreen } from '../screens/AccountScreen';
import { AdScreen } from '../screens/AdScreen';
import { HomeScreen } from '../screens/HomeScreen';

const { Navigator, Screen } = createStackNavigator();

export function HomeScreenRoutes() {
  return (
    <Navigator
      screenOptions={{
        headerStyle: {
          height: getStatusBarHeight() + 80,
          backgroundColor: theme.colors.quaternary,
        },
        headerTintColor: theme.colors.darkText,
        headerTitleStyle: {
          fontFamily: theme.fonts.title600,
          fontSize: 24,
        },
      }}
    >
      <Screen
        name="HomeScreen"
        component={HomeScreen}
        options={{ headerShown: false, title: 'Início' }}
      />
      <Screen
        name="AdScreen"
        component={AdScreen}
        options={{ title: 'Anúncio' }}
      />
    </Navigator>
  );
}

export function AdsScreenRoutes() {
  return (
    <Navigator
      screenOptions={{
        headerStyle: {
          height: getStatusBarHeight() + 80,
          backgroundColor: theme.colors.quaternary,
        },
        headerTintColor: theme.colors.darkText,
        headerTitleStyle: {
          fontFamily: theme.fonts.title600,
          fontSize: 24,
        },
      }}
    >
      <Screen
        name="AdsScreen"
        component={AdsScreen}
        options={{ headerShown: false, title: 'Anúncios' }}
      />
      <Screen
        name="AdScreen"
        component={AdScreen}
        options={{ title: 'Anúncio' }}
      />
    </Navigator>
  );
}

export function AccountScreenRoutes() {
  return (
    <Navigator
      screenOptions={{
        headerShown: false,
        cardStyle: {
          backgroundColor: 'transparent',
          opacity: 1,
        },
      }}
    >
      <Screen
        name="AccountScreen"
        component={AccountScreen}
        options={{ headerShown: false, title: 'Conta' }}
      />
      <Screen
        name="AdScreen"
        component={AdScreen}
        options={{ title: 'Anúncio' }}
      />
    </Navigator>
  );
}
