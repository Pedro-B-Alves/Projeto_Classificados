import React, { useEffect, useState } from 'react';
import { View, Text, Image, ScrollView } from 'react-native';
import AsyncStorage from '@react-native-async-storage/async-storage';
import jwtDecode from 'jwt-decode';
import { api } from '../../services/api';

import { styles } from './styles';
import PS4Img from '../../assets/ps4.png';
import { Avatar } from '../../components/Avatar';
import { Button } from '../../components/Button';

export function AdScreen({ route }) {
  const {
    idAnuncio,
    idOwner,
    adImage,
    title,
    price,
    location,
    description,
    adOwnerImage,
    adOwner,
  } = route.params;
  const [userInfo, setUserInfo] = useState({});
  const [interestsList, setInterestsList] = useState([]);
  const [teste, setTeste] = useState({});

  async function getInterestsList() {
    const token = await AsyncStorage.getItem('userToken');
    const tokenDecoded = jwtDecode(token);

    if (token !== null) {
      setUserInfo(tokenDecoded);
    }

    const { data, status } = await api.get(`/interesse/${idAnuncio}`, {
      headers: {
        Authorization: 'Bearer ' + token,
      },
    });

    if (status === 200) {
      console.log('sou os interesses', data);
      const isInterested = data.find(
        (x) => x.idUsuarioNavigation.idUsuario == tokenDecoded.jti
      );
      setInterestsList(data);
      setTeste(isInterested);
    }
  }

  useEffect(() => {
    getInterestsList();
  }, []);

  console.log('AQUIIII', idOwner, userInfo.jti);
  console.log('AQUIIII', teste);

  return (
    <View style={styles.container}>
      <ScrollView showsVerticalScrollIndicator={false}>
        <Image style={styles.image} source={{ uri: adImage }} />
        <Text style={styles.title}>
          {JSON.stringify(title).replace(/['"]+/g, '')}
        </Text>
        <Text style={styles.price}>
          R$ {JSON.stringify(price).replace(/['"]+/g, '')}
        </Text>
        <Text style={styles.subtitle}>Anunciante</Text>
        <View style={styles.ownerContainer}>
          <Avatar urlImage={adOwnerImage} />
          <Text style={styles.adOwner}>
            {JSON.stringify(adOwner).replace(/['"]+/g, '')}
          </Text>
        </View>
        <Text style={styles.subtitle}>Localização</Text>
        <Text style={styles.text}>
          {JSON.stringify(location).replace(/['"]+/g, '')}
        </Text>
        <Text style={styles.subtitle}>Descrição</Text>
        <Text style={styles.text}>
          {JSON.stringify(description).replace(/['"]+/g, '')}
        </Text>
        <View style={styles.interest}>
          {userInfo.jti != idOwner && (
            <>
              <Text style={styles.subtitle}>Ficou interessado?</Text>
              <Text style={styles.text}>
                Basta clicar no botão abaixo e demonstrar seu interesse!
              </Text>
              <Button
                title={
                  teste === undefined
                    ? 'Demonstrar interesse!'
                    : 'Já está interessado!'
                }
                ghost
              />
            </>
          )}
        </View>

        {userInfo.jti != idOwner ? (
          // Pessoas interessadas (usuário comum)
          <View>
            <Text style={styles.interestedPeople}>Pessoas interessadas</Text>
            <View style={styles.interestedContainer}>
              {interestsList.map((interest) => (
                <View
                  style={{
                    flexDirection: 'row',
                    alignItems: 'center',
                    marginTop: 6,
                    marginBottom: 6,
                  }}
                  key={interest.idInteresse}
                >
                  <Avatar urlImage={interest.idUsuarioNavigation.imagem} />
                  <Text>{interest.idUsuarioNavigation.nome}</Text>
                </View>
              ))}
            </View>
          </View>
        ) : (
          // Pessoas interessadas (dono do anúncio)
          <View>
            <Text style={styles.interestedPeople}>Pessoas interessadas</Text>
            <View style={styles.interestedContainer}>
              {interestsList.map((interest) => (
                <View
                  style={{
                    flexDirection: 'row',
                    alignItems: 'center',
                    marginTop: 6,
                    marginBottom: 6,
                  }}
                  key={interest.idInteresse}
                >
                  <Avatar urlImage={interest.idUsuarioNavigation.imagem} />
                  <View>
                    <Text>{interest.idUsuarioNavigation.nome}</Text>
                    <Text>{interest.idUsuarioNavigation.telefone}</Text>
                  </View>
                </View>
              ))}
            </View>
          </View>
        )}
      </ScrollView>
    </View>
  );
}
