import React, { useEffect, useState } from 'react';
import { View, Text, TextInput, Image, FlatList } from 'react-native';
import { ads } from '../../mock/ads';

import { styles } from './styles';
import { AdCard } from '../../components/AdCard';
import SearchIcon from '../../assets/search.png';
import axios from 'axios';

export function AdsScreen({ navigation }) {
  const [adsList, setAdsList] = useState([]);

  async function getAdsList() {
    const { data, status } = await axios.get(
      'http://192.168.1.184:5000/api/anuncio'
    );

    if (status === 200) {
      // const token = data.data.token;
      setAdsList(data);
    }
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
      <Text style={styles.title}>Todos os anúncios</Text>
      <View style={styles.inputContainer}>
        <Image style={styles.image} source={SearchIcon} />
        <TextInput style={styles.input} placeholder="Buscar" />
      </View>

      <FlatList
        showsVerticalScrollIndicator={false}
        numColumns={2}
        columnWrapperStyle={{ justifyContent: 'space-between' }}
        contentContainerStyle={{ paddingBottom: 24 }}
        data={adsList}
        keyExtractor={(item) => item.idAnuncio.toString()}
        renderItem={renderItem}
      />
    </View>
  );
}
