import React from 'react';
import { View, Text, Image } from 'react-native';

import { styles } from './styles';
import { Button } from '../../components/Button';
import Illustration01 from '../../assets/illustration-01.png';

export function Login() {
  return (
    <View style={styles.container}>
      <Image style={styles.image} source={Illustration01} />
      <View style={styles.content}>
        <Text style={styles.title}>
          Bem-vindo ao {'\n'}
          melhor site &amp; {'\n'}
          app de anúncios {'\n'}
          do Brasil!
        </Text>

        <Button title="Entrar" ghost />
        <Button title="Quero anunciar!" />
      </View>
    </View>
  );
}
