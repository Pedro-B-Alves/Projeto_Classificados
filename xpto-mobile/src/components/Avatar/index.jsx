import React from 'react';
import { View, Image } from 'react-native';

import { styles } from './styles';

export function Avatar({ urlImage }) {
  return (
    <View style={styles.container}>
      <Image style={styles.avatar} source={{ uri: urlImage }} />
    </View>
  );
}
