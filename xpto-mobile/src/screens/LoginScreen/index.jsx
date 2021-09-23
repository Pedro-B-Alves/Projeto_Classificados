import React, { useRef, useState } from 'react';
import { View, Text, Image, TextInput } from 'react-native';
import { Modalize } from 'react-native-modalize';
import AsyncStorage from '@react-native-async-storage/async-storage';

import { styles } from './styles';
import { Button } from '../../components/Button';
import Illustration01 from '../../assets/illustration-01.png';
import Illustration02 from '../../assets/illustration-login.png';
import { api } from '../../services/api';

export function LoginScreen({ navigation }) {
  const modalizeRef = useRef(null);
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');

  function handleOpenSignInModal() {
    modalizeRef.current?.open();
  }

  async function handleSignIn() {
    try {
      // if (email.trim() === '' || password.trim() === '') {
      //   return;
      // }

      navigation.navigate('AuthRoutes');

      const { data, status } = await api.post('/login', {
        email: 'pedro@gmail.com',
        senha: 'pedro1234',
      });

      // console.log(data.token);

      // const { data } = await axios.post(
      //   'https://localhost:5001/v1/account/signin',
      //   {
      //     email: email,
      //     senha: password,
      //   }
      // );

      if (status === 200) {
        const token = data.token;
        await AsyncStorage.setItem('userToken', token);
        console.log(token);
        navigation.navigate('AuthRoutes');
      }

      // console.log(data.sucesso);
    } catch (error) {
      console.warn(error);
    }
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
            <TextInput
              style={styles.input}
              onChangeText={(email) => setEmail(email)}
            />
          </View>
          <View style={[styles.formField, { marginBottom: 24 }]}>
            <Text style={styles.label}>Senha</Text>
            <TextInput
              secureTextEntry={true}
              style={styles.input}
              onChangeText={(password) => setPassword(password)}
            />
          </View>

          <Button title="Entrar" ghost onPress={handleSignIn} />
        </View>
      </Modalize>
    </View>
  );
}
