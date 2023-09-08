<script lang="ts" setup>
import ForecastDay from '~/types/ForecastDay';

defineProps<{ forecastDays: ForecastDay[] }>();
</script>

<template>
  <div class="grid lg:grid-cols-3 xl:grid-cols-5 gap-5">
    <div v-for="(day, index) in forecastDays" :key="index" class="forecast-day bg-white rounded-lg shadow-md p-4">
      <WeatherConditionIcon
        :condition="day.condition"
      />
      <WeatherConditionName
        :condition="day.condition"
      />
      <ForecastDayHigh
        :fahrenheit="day.highFahrenheit"
        :celsius="day.highCelsius"
      />
      <ForecastDayLow
        :fahrenheit="day.lowFahrenheit"
        :celsius="day.lowCelsius"
      />
    </div>
  </div>
</template>