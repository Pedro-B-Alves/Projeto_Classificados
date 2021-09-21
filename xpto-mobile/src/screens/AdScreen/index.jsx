import React from 'react';
import { View, Text, Image, ScrollView } from 'react-native';

import { styles } from './styles';
import PS4Img from '../../assets/ps4.png';
import { Avatar } from '../../components/Avatar';
import { Button } from '../../components/Button';

export function AdScreen({ route }) {
  const { urlImage, title, price, location, description, adOwner } =
    route.params;
  const role = 'Comum';

  return (
    <View style={styles.container}>
      <ScrollView showsVerticalScrollIndicator={false}>
        <Image style={styles.image} source={{ uri: urlImage }} />
        <Text style={styles.title}>
          {JSON.stringify(title).replace(/['"]+/g, '')}
        </Text>
        <Text style={styles.price}>
          R$ {JSON.stringify(price).replace(/['"]+/g, '')}
        </Text>
        <Text style={styles.subtitle}>Anunciante</Text>
        <View style={styles.ownerContainer}>
          <Avatar urlImage="https://github.com/pedro-b-alves.png" />
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
          <Text style={styles.subtitle}>Ficou interessado?</Text>
          <Text style={styles.text}>
            Basta clicar no botão abaixo e demonstrar seu interesse!
          </Text>
          <Button title="Demonstrar interesse!" ghost />
        </View>

        {role !== 'Admin' ? (
          // Pessoas interessadas (usuário comum)
          <View>
            <Text style={styles.interestedPeople}>Pessoas interessadas</Text>
            <View style={styles.interestedContainer}>
              <View style={{ flexDirection: 'row', alignItems: 'center' }}>
                <Avatar urlImage="https://github.com/gustavotolentino.png" />
                <Text>Gustavo Tolentino</Text>
              </View>
              <View
                style={{
                  flexDirection: 'row',
                  alignItems: 'center',
                  marginTop: 24,
                }}
              >
                <Avatar urlImage="https://github.com/vinixiii.png" />
                <Text>Vinícius Figueiroa</Text>
              </View>
              <View
                style={{
                  flexDirection: 'row',
                  alignItems: 'center',
                  marginTop: 24,
                }}
              >
                <Avatar urlImage="https://github.com/rafael-p.png" />
                <Text>Rafael Porto</Text>
              </View>
              <View
                style={{
                  flexDirection: 'row',
                  alignItems: 'center',
                  marginTop: 24,
                }}
              >
                <Avatar urlImage="https://github.com/renatoalvesdv.png" />
                <Text>Renato Alves</Text>
              </View>
            </View>
          </View>
        ) : (
          // Pessoas interessadas (dono do anúncio)
          <View>
            <Text style={styles.interestedPeople}>Pessoas interessadas</Text>
            <View style={styles.interestedContainer}>
              <View style={{ flexDirection: 'row', alignItems: 'center' }}>
                <Avatar urlImage="https://github.com/gustavotolentino.png" />
                <View>
                  <Text>Gustavo Tolentino</Text>
                  <Text>Tel: (11) 990909090</Text>
                </View>
              </View>
              <View
                style={{
                  flexDirection: 'row',
                  alignItems: 'center',
                  marginTop: 24,
                }}
              >
                <Avatar urlImage="https://github.com/vinixiii.png" />
                <View>
                  <Text>Vinícius Figueiroa</Text>
                  <Text>Tel: (11) 990909090</Text>
                </View>
              </View>
              <View
                style={{
                  flexDirection: 'row',
                  alignItems: 'center',
                  marginTop: 24,
                }}
              >
                <Avatar urlImage="https://github.com/vinixiii.png" />
                <View>
                  <Text>Rafael Porto</Text>
                  <Text>Tel: (11) 990909090</Text>
                </View>
              </View>
              <View
                style={{
                  flexDirection: 'row',
                  alignItems: 'center',
                  marginTop: 24,
                }}
              >
                <Avatar urlImage="https://github.com/vinixiii.png" />
                <View>
                  <Text>Renato Alves</Text>
                  <Text>Tel: (11) 990909090</Text>
                </View>
              </View>
            </View>
          </View>
        )}
      </ScrollView>
    </View>
  );
}
