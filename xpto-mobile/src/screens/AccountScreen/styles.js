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
  buttons: {
    // height: '100%',
    flexDirection: 'row',
    marginTop: 24,
    marginBottom: 12,
  },
  ads: {
    flexDirection: 'row',
    flexWrap: 'wrap',
    justifyContent: 'space-between',
    marginBottom: 24,
  },
});
