import React, { Component } from 'react';
import { View, StyleSheet } from 'react-native';
import { Win2dImageView } from './Win2DImageView';

export default class App extends Component<{}> {
  render() {
    return (
      <View style={styles.container}>
        <Win2dImageView />
      </View>
    );
  }
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#F5FCFF',
  },
});
