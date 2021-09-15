import React, { useState } from 'react';
import { View, Text, ScrollView } from 'react-native';

import { styles } from './styles';
import { Button } from '../../components/Button';
import { AdCard } from '../../components/AdCard';

export function AccountScreen() {
  const [isViewingMyAds, setIsViewingMyAds] = useState(false);

  function handleShowMyInterests() {
    setIsViewingMyAds(false);
  }

  function handleShowMyAds() {
    setIsViewingMyAds(true);
  }

  return (
    <View style={styles.container}>
      <Text style={styles.title}>Minha conta</Text>
      <View>
        <ScrollView
          horizontal
          showsHorizontalScrollIndicator={false}
          style={styles.buttons}
        >
          <Button
            title="Meus interesses"
            ghost
            onPress={handleShowMyInterests}
          />
          <Button title="Meus anúncios" ghost onPress={handleShowMyAds} />
        </ScrollView>
      </View>
      {!isViewingMyAds ? (
        <ScrollView showsVerticalScrollIndicator={false}>
          <View style={styles.ads}>
            <AdCard
              urlImage="https://github.com/vinixiii.png"
              title="PS4 Slim - 1Tb"
              location="São Paulo | SP"
              interestsNumber="10"
              price="2000"
            />
            <AdCard
              urlImage="https://github.com/vinixiii.png"
              title="PS4 Slim - 1Tb"
              location="São Paulo | SP"
              interestsNumber="10"
              price="2000"
            />
          </View>
        </ScrollView>
      ) : (
        <ScrollView showsVerticalScrollIndicator={false}>
          <View style={styles.ads}>
            <AdCard
              urlImage="https://github.com/vinixiii.png"
              title="PS4 Slim - 1Tb"
              location="São Paulo | SP"
              interestsNumber="10"
              price="2000"
            />
          </View>
        </ScrollView>
      )}
    </View>
  );
}
