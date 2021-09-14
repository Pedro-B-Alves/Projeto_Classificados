import React from 'react';
import { View, Text, TextInput, Image, ScrollView } from 'react-native';

import { styles } from './styles';
import { AdCard } from '../../components/AdCard';
import SearchIcon from '../../assets/search.png';

export function AdsScreen() {
  return (
    <View style={styles.container}>
      <Text style={styles.title}>Todos os anúncios</Text>
      <View style={styles.inputContainer}>
        <Image style={styles.image} source={SearchIcon} />
        <TextInput style={styles.input} placeholder="Buscar" />
      </View>
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
    </View>
  );
}
