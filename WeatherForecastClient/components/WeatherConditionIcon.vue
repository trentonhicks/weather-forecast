<script setup lang="ts">
import WeatherCondition from '~/types/WeatherCondition';

const { condition } = defineProps<{ condition: WeatherCondition }>();

const weatherIconClass = computed(() => {
    switch (condition) {
    case WeatherCondition.Clear:
        return 'fas fa-sun';
    case WeatherCondition.PartlyCloudy:
        return 'fas fa-cloud-sun';
    case WeatherCondition.Cloudy:
        return 'fas fa-cloud';
    case WeatherCondition.Overcast:
        return 'fas fa-cloud';
    case WeatherCondition.Fog:
        return 'fas fa-smog';
    case WeatherCondition.LightRain:
        return 'fas fa-cloud-rain';
    case WeatherCondition.HeavyRain:
        return 'fas fa-cloud-showers-heavy';
    case WeatherCondition.Thunderstorm:
        return 'fas fa-bolt';
    case WeatherCondition.Snow:
        return 'fas fa-snowflake';
    case WeatherCondition.Sleet:
        return 'fas fa-snowflake';
    case WeatherCondition.FreezingRain:
        return 'fas fa-icicles';
    case WeatherCondition.Hail:
        return 'fas fa-cloud-showers-heavy';
    case WeatherCondition.Windy:
        return 'fas fa-wind';
    default:
        return 'fas fa-question';
    }
});
</script>

<template>
    <div class="weather-icon text-2xl text-gray-700">
        <FontAwesomeIcon :icon="weatherIconClass" />
    </div>
</template>