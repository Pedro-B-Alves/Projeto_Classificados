import { StyleSheet } from 'react-native';
import { theme } from '../../global/styles/theme';

export const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: theme.colors.background,
  },
  image: {
    width: 321,
    height: 264,
  },
  content: {
    marginTop: 48,
    paddingHorizontal: 30,
  },
  title: {
    fontFamily: theme.fonts.title700,
    fontSize: 32,
    textAlign: 'center',
    color: theme.colors.darkText,
    marginBottom: 24,
  },
});
