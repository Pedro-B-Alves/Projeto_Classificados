import React, { useEffect, useState } from 'react';
import { View, Text, Image, FlatList } from 'react-native';
import AsyncStorage from '@react-native-async-storage/async-storage';
import jwtDecode from 'jwt-decode';
import { ads } from '../../mock/ads';
import { api } from '../../services/api';

import { styles } from './styles';
import { Avatar } from '../../components/Avatar';
import { AdCard } from '../../components/AdCard';

import Illustration02 from '../../assets/illustration-02.png';

export function HomeScreen({ navigation }) {
  const [userInfo, setUserInfo] = useState({});
  const [adsList, setAdsList] = useState([]);

  async function getAdsList() {
    const { data, status } = await api.get('/anuncio');

    if (status === 200) {
      const recentAds = data.slice(0, 4).map((item) => item);
      setAdsList(recentAds);
    }
  }

  async function getStorageData() {
    const token = await AsyncStorage.getItem('userToken');
    const tokenDecoded = jwtDecode(token);

    if (token !== null) {
      setUserInfo(tokenDecoded);
    }
  }

  useEffect(() => {
    getStorageData();
    getAdsList();
  }, []);

  function handleShowAd(item) {
    navigation.navigate('AdScreen', {
      adImage: item.imagem,
      title: item.nome,
      price: item.preco,
      location: item.idUsuarioNavigation.cidade,
      description: item.descricao,
      adOwnerImage: item.idUsuarioNavigation.imagem,
      adOwner: item.idUsuarioNavigation.nome,
    });
  }

  const renderItem = ({ item }) => (
    <AdCard
      urlImage={item.imagem}
      title={item.nome}
      location={item.idUsuarioNavigation.cidade}
      interestsNumber="10"
      price={item.preco}
      onPress={() => handleShowAd(item)}
    />
  );

  return (
    <View style={styles.container}>
      <View style={styles.header}>
        <Avatar urlImage="http://github.com/vinixiii.png" />
        <View>
          <View style={styles.user}>
            <Text style={styles.greeting}>Olá, </Text>
            <Text style={styles.username}>{userInfo.family_name}</Text>
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

      {/* <ScrollView
        style={styles.recentAds}
        horizontal
        showsHorizontalScrollIndicator={false}
      > */}
      <FlatList
        showsVerticalScrollIndicator={false}
        numColumns={2}
        columnWrapperStyle={{ justifyContent: 'space-between' }}
        contentContainerStyle={{ paddingBottom: 24 }}
        data={adsList}
        keyExtractor={(item) => item.idAnuncio.toString()}
        renderItem={renderItem}
      />
      {/* </ScrollView> */}
    </View>
  );
}
