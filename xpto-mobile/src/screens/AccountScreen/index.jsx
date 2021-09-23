import React, { useState, useEffect } from 'react';
import { View, Text, ScrollView, FlatList } from 'react-native';
import { api } from '../../services/api';

import { styles } from './styles';
import { Button } from '../../components/Button';
import { AdCard } from '../../components/AdCard';

export function AccountScreen({ navigation }) {
  const [isViewingMyAds, setIsViewingMyAds] = useState(false);
  const [myAdsList, setMyAdsList] = useState([]);
  const [myInterestsList, setMyInterestsList] = useState([]);

  async function getAdsList() {
    const { data, status } = await api.get('/anuncio');

    if (status === 200) {
      const recentAds = data.slice(0, 4).map((item) => item);
      const recentAds2 = data.slice(4).map((item) => item);
      setMyAdsList(recentAds);
      setMyInterestsList(recentAds2);
    }
  }

  function handleShowMyInterests() {
    setIsViewingMyAds(false);
  }

  function handleShowMyAds() {
    setIsViewingMyAds(true);
  }

  useEffect(() => {
    getAdsList();
  }, []);

  function handleShowAd(item) {
    navigation.navigate('AdScreen', {
      idAnuncio: item.idAnuncio,
      idOwner: item.idUsuario,
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
        <FlatList
          showsVerticalScrollIndicator={false}
          numColumns={2}
          columnWrapperStyle={{ justifyContent: 'space-between' }}
          contentContainerStyle={{ paddingBottom: 24 }}
          data={myAdsList}
          keyExtractor={(item) => item.idAnuncio.toString()}
          renderItem={renderItem}
        />
      ) : (
        <FlatList
          showsVerticalScrollIndicator={false}
          numColumns={2}
          columnWrapperStyle={{ justifyContent: 'space-between' }}
          contentContainerStyle={{ paddingBottom: 24 }}
          data={myInterestsList}
          keyExtractor={(item) => item.idAnuncio.toString()}
          renderItem={renderItem}
        />
      )}
    </View>
  );
}
