import React from 'react';
import { TouchableOpacity, Text } from 'react-native';
import { styles } from './styles';

export function Button({ title, ghost, ...rest }) {
  return (
    <TouchableOpacity
      style={ghost ? styles.ghostContainer : styles.container}
      activeOpacity={0.7}
      {...rest}
    >
      <Text style={ghost ? styles.ghostTitle : styles.title}>{title}</Text>
    </TouchableOpacity>
  );
}
