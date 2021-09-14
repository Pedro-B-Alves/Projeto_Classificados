import { StyleSheet } from 'react-native';
import { theme } from '../../global/styles/theme';

export const styles = StyleSheet.create({
  container: {
    width: 160,
    backgroundColor: theme.colors.tertiary,
    borderRadius: 12,
    marginTop: 24,
    marginHorizontal: 4,
  },
  imageContainer: {
    width: '100%',
    height: 160,
    padding: 12,
  },
  image: {
    width: '100%',
    height: '100%',
    borderRadius: 12,
  },
  title: {
    fontFamily: theme.fonts.title600,
    fontSize: 18,
    paddingHorizontal: 12,
  },
  location: {
    fontFamily: theme.fonts.text400,
    fontSize: 16,
    paddingHorizontal: 12,
  },

  footer: {
    width: '100%',
    backgroundColor: theme.colors.quaternary,
    paddingHorizontal: 12,
    flexDirection: 'row',
    alignItems: 'center',
    justifyContent: 'space-between',
    marginTop: 24,
    paddingVertical: 12,
  },
  interests: {
    flexDirection: 'row',
    alignItems: 'center',
  },
  interestsNumber: {
    fontFamily: theme.fonts.text400,
    fontSize: 16,
    color: theme.colors.darkText,
    marginRight: 8,
  },
  icon: {
    width: 15,
    height: 15,
  },
  price: {
    fontFamily: theme.fonts.text500,
    fontSize: 16,
    color: theme.colors.darkText,
  },
});
