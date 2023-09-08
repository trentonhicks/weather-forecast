<script lang="ts" setup>
import ForecastDay from '~/types/ForecastDay';

defineProps<{ forecastDays: ForecastDay[] }>();
</script>

<template>
  <div class="grid place-items-center max-w-3xl mx-auto rounded-lg overflow-hidden">
    <div class="forecast-day bg-white/60 border-b border-gray-500/50 shadow-md p-4 w-full">
      <div class="font-bold text-gray-700 place-self-start uppercase flex gap-x-3 items-center">
        <FontAwesomeIcon icon="fas fa-calendar" />
        <div>5-day forecast</div>
      </div>
    </div>
    <div v-for="(day, index) in forecastDays" :key="index" class="forecast-day bg-white/60 border-b border-gray-500/50 shadow-md py-4 px-6 w-full grid grid-cols-4 place-items-end items-center">
      <div class="font-bold text-lg text-gray-950/90 place-self-start leading-relaxed">
        <div>Day {{ index + 1 }}</div>
      </div>
      <div class="flex gap-x-3 items-center place-self-start">
        <WeatherConditionIcon
          :condition="day.condition"
          class="w-10"
        />
        <WeatherConditionName
          :condition="day.condition"
        />
      </div>
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