import React from 'react';
import { createMaterialBottomTabNavigator } from '@react-navigation/material-bottom-tabs';
import { MaterialCommunityIcons } from '@expo/vector-icons';

import { theme } from '../../src/global/styles/theme';
import { HomeScreen } from '../screens/HomeScreen';
import { AdsScreenRoutes, AccountScreenRoutes } from './ad.routes';
// import { AdsScreen } from '../screens/AdsScreen';
// import { AccountScreen } from '../screens/AccountScreen';

const { Navigator, Screen } = createMaterialBottomTabNavigator();

export function AuthRoutes() {
  return (
    //Define que haverá navegação
    <Navigator
      activeColor={theme.colors.primary}
      inactiveColor={theme.colors.tertiary}
      barStyle={{
        backgroundColor: theme.colors.secondary,
        // height: 60,
      }}
      screenOptions={({ route }) => ({
        tabBarIcon: ({ color }) => {
          if (route.name === 'HomeScreen') {
            return (
              <MaterialCommunityIcons
                name="home-outline"
                size={24}
                color={color}
              />
            );
          }
          if (route.name === 'AdsScreenRoutes') {
            return (
              <MaterialCommunityIcons
                name="storefront-outline"
                size={24}
                color={color}
              />
            );
          }
          if (route.name === 'AccountScreenRoutes') {
            return (
              <MaterialCommunityIcons
                name="account-outline"
                size={24}
                color={color}
              />
            );
          }
        },
      })}
    >
      <Screen
        name="HomeScreen"
        component={HomeScreen}
        options={{
          tabBarLabel: 'Início',
        }}
      />
      <Screen
        name="AdsScreenRoutes"
        component={AdsScreenRoutes}
        options={{
          tabBarLabel: 'Anúncios',
        }}
      />
      <Screen
        name="AccountScreenRoutes"
        component={AccountScreenRoutes}
        options={{
          tabBarLabel: 'Conta',
        }}
      />
    </Navigator>
  );
}
