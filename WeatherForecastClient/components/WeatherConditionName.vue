<script setup lang="ts">
import WeatherCondition from '~/types/WeatherCondition';

defineProps<{ condition: WeatherCondition }>();

const weatherConditionName = (condition: WeatherCondition) => {
  switch (condition) {
    case WeatherCondition.Clear:
      return 'Clear';
    case WeatherCondition.PartlyCloudy:
      return 'Partly Cloudy';
    case WeatherCondition.Cloudy:
      return 'Cloudy';
    case WeatherCondition.Overcast:
      return 'Overcast';
    case WeatherCondition.Fog:
      return 'Fog';
    case WeatherCondition.LightRain:
      return 'Light Rain';
    case WeatherCondition.HeavyRain:
      return 'Heavy Rain';
    case WeatherCondition.Thunderstorm:
      return 'Thunderstorm';
    case WeatherCondition.Snow:
      return 'Snow';
    case WeatherCondition.Sleet:
      return 'Sleet';
    case WeatherCondition.FreezingRain:
      return 'Freezing Rain';
    case WeatherCondition.Hail:
      return 'Hail';
    case WeatherCondition.Windy:
      return 'Windy';
    default:
      return 'Unknown';
  }
};
</script>

<template>
    <p class="font-bold text-lg text-gray-950/90">{{ weatherConditionName(condition) }}</p>
</template>