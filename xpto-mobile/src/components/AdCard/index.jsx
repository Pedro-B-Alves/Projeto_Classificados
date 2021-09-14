import React from 'react';
import { View, TouchableOpacity, Text, Image } from 'react-native';

import { styles } from './styles';
import HeartImg from '../../assets/heart.png';

export function AdCard({
  urlImage,
  title,
  location,
  interestsNumber,
  price,
  ...rest
}) {
  return (
    <TouchableOpacity style={styles.container} activeOpacity={0.7} {...rest}>
      <View style={styles.imageContainer}>
        <Image style={styles.image} source={{ uri: urlImage }} />
      </View>

      <Text style={styles.title} numberOfLines={1}>
        {title}
      </Text>
      <Text style={styles.location}>{location}</Text>

      <View style={styles.footer}>
        <View style={styles.interests}>
          <Text style={styles.interestsNumber}>{interestsNumber}</Text>
          <Image style={styles.icon} source={HeartImg} />
        </View>
        <Text style={styles.price}>R$ {price}</Text>
      </View>
    </TouchableOpacity>
  );
}
