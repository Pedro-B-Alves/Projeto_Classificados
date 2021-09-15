import React from 'react';
import { createMaterialBottomTabNavigator } from '@react-navigation/material-bottom-tabs';
import { MaterialIcons, MaterialCommunityIcons } from '@expo/vector-icons';

import { Home } from '../screens/Home';
import { AdsScreen } from '../screens/AdsScreen';
import { theme } from '../../src/global/styles/theme';

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
          if (route.name === 'Home') {
            return (
              <MaterialCommunityIcons
                name="home-outline"
                size={24}
                color={color}
              />
            );
          }
          if (route.name === 'AdsScreen') {
            return (
              <MaterialIcons
                containerStyle={{ padding: 6 }}
                name="storefront"
                size={24}
                color={color}
              />
            );
          }
        },
      })}
    >
      <Screen name="Home" component={Home}></Screen>
      <Screen name="AdsScreen" component={AdsScreen}></Screen>
    </Navigator>
  );
}
