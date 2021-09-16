import { StyleSheet } from 'react-native';

import { theme } from '../../global/styles/theme';

export const styles = StyleSheet.create({
  container: {
    flex: 1,
    paddingHorizontal: 30,
    backgroundColor: theme.colors.background,
  },
  image: {
    width: '100%',
    height: 250,
    marginVertical: 24,
    borderRadius: 12,
  },
  title: {
    marginTop: 12,
    fontFamily: theme.fonts.title600,
    fontSize: 24,
    color: theme.colors.darkText,
  },
  price: {
    fontFamily: theme.fonts.title700,
    fontSize: 24,
    color: theme.colors.primary,
  },
  subtitle: {
    fontFamily: theme.fonts.title600,
    fontSize: 18,
    color: theme.colors.darkText,
    alignSelf: 'flex-start',
  },
  ownerContainer: {
    marginTop: 12,
    marginBottom: 24,
    flexDirection: 'row',
    alignItems: 'center',
  },
  adOwner: {
    fontFamily: theme.fonts.title600,
    fontSize: 16,
    color: theme.colors.darkText,
  },
  text: {
    fontFamily: theme.fonts.text400,
    fontSize: 16,
    color: theme.colors.darkText,
    alignSelf: 'flex-start',
    marginBottom: 24,
  },
  interest: {
    alignItems: 'center',
    textAlign: 'left',
  },

  interestedPeople: {
    fontFamily: theme.fonts.title600,
    fontSize: 18,
    color: theme.colors.darkText,
    marginTop: 24,
  },
  interestedContainer: {
    backgroundColor: theme.colors.tertiary,
    borderRadius: 12,
    padding: 24,
    marginTop: 12,
    marginBottom: 24,
  },
});
