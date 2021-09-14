import React from 'react';
import { View, Text, ScrollView, Image } from 'react-native';

import { styles } from './styles';
import { Avatar } from '../../components/Avatar';
import { AdCard } from '../../components/AdCard';

import Illustration02 from '../../assets/illustration-02.png';

export function Home() {
  return (
    <View style={styles.container}>
      <View style={styles.header}>
        <Avatar urlImage="http://github.com/vinixiii.png" />
        <View>
          <View style={styles.user}>
            <Text style={styles.greeting}>Olá, </Text>
            <Text style={styles.username}>Vinícius</Text>
          </View>

          <Text style={styles.message}>Hoje é dia de desapegar!</Text>
        </View>
      </View>

      <View style={styles.banner}>
        <Text style={styles.bannerText}>
          O melhor site &amp; {'\n'}
          app de anúnicos {'\n'}
          do Brasil!
        </Text>
        <Image source={Illustration02} style={styles.image} />
      </View>

      <Text style={styles.title}>Anúncios recentes</Text>

      <ScrollView
        style={styles.recentAds}
        horizontal={true}
        showsHorizontalScrollIndicator={false}
      >
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
      </ScrollView>
    </View>
  );
}
