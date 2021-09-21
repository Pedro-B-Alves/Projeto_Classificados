import React from 'react';
import { View, Text, TextInput, Image, FlatList } from 'react-native';
import { ads } from '../../mock/ads';

import { styles } from './styles';
import { AdCard } from '../../components/AdCard';
import SearchIcon from '../../assets/search.png';

export function AdsScreen({ navigation }) {
  function handleShowAd(item) {
    navigation.navigate('AdScreen', {
      urlImage: item.urlImage,
      title: item.title,
      price: item.price,
      location: item.location,
      description: item.description,
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
      inHorizontal
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
        data={ads}
        keyExtractor={(item) => item.id.toString()}
        renderItem={renderItem}
      />
    </View>
  );
}
