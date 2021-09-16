import React, { useRef } from 'react';
import { View, Text, Image, TextInput } from 'react-native';
import { Modalize } from 'react-native-modalize';

import { styles } from './styles';
import { Button } from '../../components/Button';
import Illustration01 from '../../assets/illustration-01.png';
import Illustration02 from '../../assets/illustration-login.png';

export function LoginScreen({ navigation }) {
  const modalizeRef = useRef(null);

  function handleOpenSignInModal() {
    modalizeRef.current?.open();
  }

  function handleSignIn() {
    navigation.navigate('AuthRoutes');
  }

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

        <Button title="Entrar" ghost onPress={handleOpenSignInModal} />
        <Button title="Quero anunciar!" />
      </View>

      <Modalize
        ref={modalizeRef}
        modalStyle={{
          backgroundColor: '#f6f6f6',
        }}
      >
        <View style={styles.modalContainer}>
          <Image
            style={[styles.image, { marginTop: 48 }]}
            source={Illustration02}
          />
          <Text style={styles.subtitle}>Faça seu login!</Text>
          <View style={styles.formField}>
            <Text style={styles.label}>E-mail</Text>
            <TextInput style={styles.input} />
          </View>
          <View style={[styles.formField, { marginBottom: 24 }]}>
            <Text style={styles.label}>Senha</Text>
            <TextInput style={styles.input} />
          </View>

          <Button title="Entrar" ghost onPress={handleSignIn} />
        </View>
      </Modalize>
    </View>
  );
}
