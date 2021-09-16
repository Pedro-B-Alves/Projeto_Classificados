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
    justifyContent: 'center',
    alignItems: 'center',
  },
  title: {
    fontFamily: theme.fonts.title700,
    fontSize: 32,
    textAlign: 'center',
    color: theme.colors.darkText,
    marginBottom: 24,
  },

  modalContainer: {
    flex: 1,
    paddingHorizontal: 30,
    justifyContent: 'center',
    alignItems: 'center',
  },
  subtitle: {
    fontFamily: theme.fonts.title600,
    fontSize: 24,
    color: theme.colors.darkText,
    alignSelf: 'flex-start',
    marginVertical: 24,
  },
  formField: {
    width: '100%',
    marginVertical: 8,
    alignItems: 'flex-start',
  },
  label: {
    flex: 1,
    fontFamily: theme.fonts.text500,
    fontSize: 18,
    color: theme.colors.darkText,
  },
  input: {
    width: '100%',
    height: 56,
    borderRadius: 12,
    paddingHorizontal: 12,
    backgroundColor: theme.colors.tertiary,
  },
});
