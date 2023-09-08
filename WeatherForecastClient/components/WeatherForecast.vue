<script lang="ts" setup>
import ForecastDay from '~/types/ForecastDay';

defineProps<{ forecastDays: ForecastDay[], displayFahrenheit: boolean }>();
</script>

<template>
  <div class="grid place-items-center max-w-lg mx-auto rounded-lg overflow-hidden">
    <div class="forecast-day bg-white/60 border-b border-gray-500/50 shadow-md p-4 w-full">
      <div class="font-bold text-gray-700 place-self-start uppercase flex gap-x-3 items-center">
        <FontAwesomeIcon icon="fas fa-calendar" />
        <div>5-day forecast</div>
      </div>
    </div>
    <div v-for="(day, index) in forecastDays" :key="index" class="forecast-day bg-white/60 border-b border-gray-500/50 shadow-md py-4 px-6 w-full grid grid-cols-4 place-items-center items-center">
      <div class="font-bold text-lg text-gray-950/90 leading-relaxed place-self-start items-center">
        <div>Day {{ index + 1 }}</div>
      </div>
      <div class="flex gap-x-3 items-center">
        <WeatherConditionIcon
          :condition="day.condition"
        />
      </div>
      <ForecastDayLow
        :fahrenheit="day.lowFahrenheit"
        :celsius="day.lowCelsius"
        :display-fahrenheit="displayFahrenheit"
      />
      <ForecastDayHigh
        :fahrenheit="day.highFahrenheit"
        :celsius="day.highCelsius"
        :display-fahrenheit="displayFahrenheit"
      />
    </div>
  </div>
</template>