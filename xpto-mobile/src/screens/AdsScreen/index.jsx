import React from 'react';
import { View, Text, TextInput, Image, FlatList } from 'react-native';
import { ads } from '../../mock/ads';

import { styles } from './styles';
import { AdCard } from '../../components/AdCard';
import SearchIcon from '../../assets/search.png';

export function AdsScreen({ navigation }) {
  function handleShowAd(id) {
    navigation.navigate('AdScreen', {
      id: id,
      title: 'PS4 Slim - 1Tb',
      price: '2000',
      location: 'São Paulo | SP',
      description:
        'É usado mas está em ótimas condições. Nunca apresentou nenhum defeito e é super silencioso',
      adOwner: 'Pedro Brito',
    });
  }

  const renderItem = ({ item }) => (
    <AdCard
      urlImage={item.urlImage}
      title={item.title}
      location={item.location}
      interestsNumber={item.interestsNumber}
      price={item.price}
      onPress={() => handleShowAd(item.id)}
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
        data={ads}
        keyExtractor={(item) => item.id.toString()}
        renderItem={renderItem}
      />
    </View>
  );
}
