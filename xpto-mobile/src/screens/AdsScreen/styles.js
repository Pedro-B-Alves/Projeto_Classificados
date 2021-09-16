import { StyleSheet } from 'react-native';
import { getStatusBarHeight } from 'react-native-iphone-x-helper';

import { theme } from '../../global/styles/theme';

export const styles = StyleSheet.create({
  container: {
    flex: 1,
    paddingHorizontal: 30,
    backgroundColor: theme.colors.background,
  },
  title: {
    marginTop: getStatusBarHeight() + 32,
    fontFamily: theme.fonts.title600,
    fontSize: 24,
    color: theme.colors.darkText,
  },
  inputContainer: {
    width: '100%',
    height: 56,
    flexDirection: 'row',
    alignItems: 'center',
    borderRadius: 12,
    marginTop: 24,
    backgroundColor: theme.colors.tertiary,
    marginBottom: 12,
  },
  image: {
    width: 20,
    height: 20,
    marginRight: 12,
    marginLeft: 12,
  },
  input: {
    width: '100%',
    fontSize: 16,
  },
  ads: {
    flexDirection: 'row',
    flexWrap: 'wrap',
    justifyContent: 'space-between',
    marginBottom: 24,
  },
});
